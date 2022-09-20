//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by https://github.com/StefH/FluentBuilder version 0.6.0.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using FluentBuilderGeneratorTests.FluentBuilder;
using FluentBuilderGeneratorTests.DTO;

namespace FluentBuilderGeneratorTests.DTO2
{
    public partial class MyOptionBuilder : Builder<FluentBuilderGeneratorTests.DTO.Option>
    {
        private bool _nameIsSet;
        private Lazy<string> _name = new Lazy<string>(() => string.Empty);
        public MyOptionBuilder WithName(string value) => WithName(() => value);
        public MyOptionBuilder WithName(Func<string> func)
        {
            _name = new Lazy<string>(func);
            _nameIsSet = true;
            return this;
        }
        public MyOptionBuilder WithoutName()
        {
            WithName(() => string.Empty);
            _nameIsSet = false;
            return this;
        }


        public override Option Build(bool useObjectInitializer = true)
        {
            if (Object?.IsValueCreated != true)
            {
                Object = new Lazy<Option>(() =>
                {
                    Option instance;
                    if (useObjectInitializer)
                    {
                        instance = new Option
                        {
                            Name = _name.Value
                        };

                        return instance;
                    }

                    instance = new Option();
                    if (_nameIsSet) { instance.Name = _name.Value; }

                    return instance;
                });
            }

            PostBuild(Object.Value);

            return Object.Value;
        }

        public static Option Default() => new Option();

    }
}
#nullable disable