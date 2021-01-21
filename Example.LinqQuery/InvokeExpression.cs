using System;
using System.Linq.Expressions;
using Example.LinqQuery.Model;

namespace Example.LinqQuery
{
    public class InvokeExpression
    {
        /// <summary>
        /// You can invoke the delegate wrapped by an Expression the same way as a delegate, but first you need to compile it using the Compile() method.
        /// Compile() returns delegateof Func or Action type so that you can invoke it like a delegate.
        /// </summary>
        public void Example()
        {
            Expression<Func<Student, bool>> isTeenAgerExpr = s => s.Age > 12 && s.Age < 20;

            //compile Expression using Compile method to invoke it as Delegate
            Func<Student, bool> isTeenAger = isTeenAgerExpr.Compile();

            //Invoke
            bool result = isTeenAger(new Student() {StudentID = 1, StudentName = "Steve", Age = 20});

            Console.WriteLine(result);
        }
    }
}