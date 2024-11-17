using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Symbolics; // Asegúrate de agregar esta referencia
using Expr = MathNet.Symbolics.SymbolicExpression;
namespace Proyecto_CalculoDiferencial.forms
{
    public partial class frmdivididas : Form
    {
        public frmdivididas()
        {
            InitializeComponent();
        }

        private void frmdivididas_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string inputFuncion = txtFuncion.Text;

            if (string.IsNullOrWhiteSpace(inputFuncion))
            {
                MessageBox.Show("Por favor, introduce una función válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!EsFuncionValida(inputFuncion))
            {
                MessageBox.Show("La función ingresada no es válida. Revisa la sintaxis.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Limpiar resultados anteriores
            txtResultados.Clear();

            try
            {
                // Procesar y traducir la función
                string funcionTraducida = TraducirFunciones(inputFuncion);
                var funcion = Expr.Parse(funcionTraducida);

                // Derivar la función
                var derivada = funcion.Differentiate("x");
                var segundaDerivada = derivada.Differentiate("x");

                // Mostrar las derivadas
                txtResultados.AppendText($"Función original: {funcion}\n");
                txtResultados.AppendText($"Primera derivada: {derivada}\n");
                txtResultados.AppendText($"Segunda derivada: {segundaDerivada}\n\n");

                // Detectar máximos y mínimos
                DetectarExtremos(funcion, derivada, segundaDerivada);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DetectarExtremos(Expr funcion, Expr derivada, Expr segundaDerivada)
        {
            txtResultados.AppendText("Máximos y mínimos:\n");

            // Buscar puntos críticos (cuando derivada = 0)
            double[] xValues = Enumerable.Range(-10, 21).Select(i => (double)i).ToArray();
            foreach (var x in xValues)
            {
                double valorDerivada = EvaluarFuncion(derivada, x);

                // Verificar si g'(x) ≈ 0
                if (Math.Abs(valorDerivada) < 1e-5)
                {
                    double valorSegundaDerivada = EvaluarFuncion(segundaDerivada, x);
                    double valorFuncion = EvaluarFuncion(funcion, x);

                    if (valorSegundaDerivada > 0)
                        txtResultados.AppendText($"Mínimo en x = {x:F2}, g(x) = {valorFuncion:F4}\n");
                    else if (valorSegundaDerivada < 0)
                        txtResultados.AppendText($"Máximo en x = {x:F2}, g(x) = {valorFuncion:F4}\n");
                    else
                        txtResultados.AppendText($"Punto de inflexión en x = {x:F2}, g(x) = {valorFuncion:F4}\n");
                }
            }

            txtResultados.AppendText("\n");
        }

        private double EvaluarFuncion(Expr funcion, double x)
        {
            try
            {
                // Crear diccionario de parámetros
                var variables = new Dictionary<string, FloatingPoint>
                {
                    { "x", (FloatingPoint)x }
                };

                // Evaluar la expresión con los valores de las variables
                var resultado = funcion.Evaluate(variables);

                // Convertir el resultado a double
                if (resultado.IsReal)
                {
                    return resultado.RealValue;
                }

                throw new Exception("El resultado no se puede convertir a un valor real.");
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al evaluar la función en x = {x}: {ex.Message}");
            }
        }

        private string TraducirFunciones(string funcion)
        {
            // Reemplazos básicos para funciones comunes
            funcion = funcion.Replace("sen", "sin") // Cambiar 'sen' a 'sin'
                             .Replace("cos", "cos")
                             .Replace("tan", "tan")
                             .Replace("ln", "log") // Cambiar 'ln' a 'log'
                             .Replace("√", "sqrt"); // Cambiar '√' a 'sqrt'

            // Manejar multiplicación implícita
            // Entre paréntesis consecutivos
            funcion = System.Text.RegularExpressions.Regex.Replace(funcion, @"(\))(\()", "$1*$2");
            // Entre número/letra y paréntesis
            funcion = System.Text.RegularExpressions.Regex.Replace(funcion, @"([0-9a-zA-Z])(\()", "$1*$2");
            // Entre paréntesis y número/letra
            funcion = System.Text.RegularExpressions.Regex.Replace(funcion, @"(\))([0-9a-zA-Z])", "$1*$2");

            return funcion;
        }
        private bool EsFuncionValida(string funcion)
        {
            try
            {
                // Intentar traducir y parsear la función
                string funcionTraducida = TraducirFunciones(funcion);
                var parsed = Expr.Parse(funcionTraducida);
                return true;
            }
            catch
            {
                // Si no se puede parsear, no es válida
                return false;
            }
        }


    }
}
