using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MathParser
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static decimal parse(string input)
        {

            decimal partialResult = -1;
            string question = string.Empty;
            string partialQuestion = string.Empty;
            string manipulate = input;

            SimpleExpressionEvaluator.ExpressionEvaluator EV = new SimpleExpressionEvaluator.ExpressionEvaluator();

            string reg = @"^[\d]{1,4}[abcd]{1}[\d]{1,4}";
            string reg2 = @"[\d]{1,4}[abcd]{1}[\d]{1,4}";

            Match m = Regex.Match(manipulate, reg);

            while (m.Success)
            {

                partialQuestion = m.Value.Replace("a", "+");
                partialQuestion = partialQuestion.Replace('b', '-');
                partialQuestion = partialQuestion.Replace('c', '*');
                partialQuestion = partialQuestion.Replace('d', '/');

                partialResult = EV.Evaluate(partialQuestion);

                manipulate = manipulate.Replace(m.Value, partialResult.ToString());

                m = Regex.Match(manipulate, reg2);

            }

            question = manipulate.Replace("a", "+");
            question = question.Replace('b', '-');
            question = question.Replace('c', '*');
            question = question.Replace('d', '/');
            question = question.Replace('e', '(');
            question = question.Replace('f', ')');

            return EV.Evaluate(question);

        }
    }
}
