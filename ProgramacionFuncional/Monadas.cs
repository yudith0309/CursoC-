namespace ProgramacionFuncional
{
    public  class Monadas
    {
        public Monadas() { 
        var discount = (decimal monto) => monto / 12;
        var cargo = (decimal monto) => monto * 4;
        decimal monto = 100;
        decimal total = 
                monto
                .Pipe(discount)
                .Pipe(cargo);

        //Ejemplo con Clases 
        var lis = (List<string> l )=>l.Select(e=>e.ToUpper()).ToList();
        var lis1 = (List<string> l1)=>l1.OrderBy(e=>e).ToList();

            var beer = new List<string>()
        {
            "Cristal","Mayabe","Bucanero"
        };
            var beer1 = beer.PipeClass(lis).PipeClass(lis1);
       }
       
    }

    public static class MethodStatic
    {
        //Encadenamiento de funciones 
        public static TOut Pipe<TIn, TOut>(this TIn v, Func<TIn, TOut> FnOut) where TIn : struct where TOut : struct
        {
            return FnOut(v);
        }

        public static TOut PipeClass<TIn, TOut>(this TIn v, Func<TIn, TOut> FnOut) where TIn : class where TOut : class
        {
            return FnOut(v);
        }
    }


}
