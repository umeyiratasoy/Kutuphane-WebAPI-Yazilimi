using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.IoC
{
    public interface ICoreModule // bU FRAMEWORK katmanı şirket değiştirsek bile bşaka yerde kullanabilecğeimiz kodlar.
    {
        void Load(IServiceCollection serviceCollection);
    }
}
