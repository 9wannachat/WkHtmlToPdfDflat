using System;

namespace WkHtmlToPdfDflat
{
    public class IntegerEventArgs:
        EventArgs
    {
        public IntegerEventArgs(
                Converter converter,
                int val,
                object arg)
        {
            if(converter == null)
                throw new ArgumentNullException("converter");

            this.Converter = converter;
            this.Value = val;
            this.Arg = arg;
        }

        public Converter Converter { get; private set; }

        public object Arg { get; private set; }

        public int Value { get; private set; }
    }
}
