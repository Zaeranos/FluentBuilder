//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by https://github.com/StefH/FluentBuilder version 0.7.1.0
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

namespace FluentBuilderGeneratorTests.DTO
{
    public partial class ThingWithParameterizedConstructorBuilder : Builder<FluentBuilderGeneratorTests.DTO.ThingWithParameterizedConstructor>
    {
        private bool _xIsSet;
        private Lazy<int> _x = new Lazy<int>(() => default(int));
        public ThingWithParameterizedConstructorBuilder WithX(int value) => WithX(() => value);
        public ThingWithParameterizedConstructorBuilder WithX(Func<int> func)
        {
            _x = new Lazy<int>(func);
            _xIsSet = true;
            return this;
        }

        private bool _Constructor_1554208865_IsSet;
        private Lazy<FluentBuilderGeneratorTests.DTO.ThingWithParameterizedConstructor> _Constructor_1554208865 = new Lazy<FluentBuilderGeneratorTests.DTO.ThingWithParameterizedConstructor>(() => new FluentBuilderGeneratorTests.DTO.ThingWithParameterizedConstructor());
        public ThingWithParameterizedConstructorBuilder UsingConstructor()
        {
            _Constructor_1554208865 = new Lazy<FluentBuilderGeneratorTests.DTO.ThingWithParameterizedConstructor>(() =>
            {
                return new FluentBuilderGeneratorTests.DTO.ThingWithParameterizedConstructor
                (

                );
            });
            _Constructor_1554208865_IsSet = true;

            return this;
        }

        private bool _Constructor_722069126_IsSet;
        private Lazy<FluentBuilderGeneratorTests.DTO.ThingWithParameterizedConstructor> _Constructor_722069126 = new Lazy<FluentBuilderGeneratorTests.DTO.ThingWithParameterizedConstructor>(() => new FluentBuilderGeneratorTests.DTO.ThingWithParameterizedConstructor(default(int)));
        public ThingWithParameterizedConstructorBuilder UsingConstructor(int x)
        {
            _Constructor_722069126 = new Lazy<FluentBuilderGeneratorTests.DTO.ThingWithParameterizedConstructor>(() =>
            {
                return new FluentBuilderGeneratorTests.DTO.ThingWithParameterizedConstructor
                (
                    x
                );
            });
            _Constructor_722069126_IsSet = true;

            return this;
        }


        public override ThingWithParameterizedConstructor Build() => Build(true);

        public override ThingWithParameterizedConstructor Build(bool useObjectInitializer)
        {
            if (Instance?.IsValueCreated != true)
            {
                Instance = new Lazy<ThingWithParameterizedConstructor>(() =>
                {
                    ThingWithParameterizedConstructor instance;
                    if (useObjectInitializer)
                    {
                        instance = new ThingWithParameterizedConstructor
                        {
                            X = _x.Value
                        };

                        return instance;
                    }

                    if (_Constructor_1554208865_IsSet) { instance = _Constructor_1554208865.Value; }
                    else if (_Constructor_722069126_IsSet) { instance = _Constructor_722069126.Value; }
                    else { instance = Default(); }

                    if (_xIsSet) { instance.X = _x.Value; }

                    return instance;
                });
            }

            PostBuild(Instance.Value);

            return Instance.Value;
        }

        public static ThingWithParameterizedConstructor Default() => new ThingWithParameterizedConstructor();

    }
}
#nullable disable