using System;
using System.Windows.Markup;

namespace CIL.Extentions
{
    public class ContainerExtension : MarkupExtension
    {
        public ContainerExtension(Type type)
        {
            Type = type;
        }

        public Type Type { get; set; }

        // ProvideValue, which returns an object instance from the container
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            if (serviceProvider == null)
                throw new ArgumentNullException("serviceProvider");

            if (Type == null)
                throw new NullReferenceException("Type");

            return IoC.Instance.GetInstance(Type);
        }
    }
}
