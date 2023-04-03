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
    public partial class ThingBuilder : Builder<FluentBuilderGeneratorTests.DTO.Thing>
    {
        private bool _tIsSet;
        private Lazy<FluentBuilderGeneratorTests.DTO.Thing> _t = new Lazy<FluentBuilderGeneratorTests.DTO.Thing>(() => new FluentBuilderGeneratorTests.DTO.Thing());
        public ThingBuilder WithT(FluentBuilderGeneratorTests.DTO.Thing value) => WithT(() => value);
        public ThingBuilder WithT(Func<FluentBuilderGeneratorTests.DTO.Thing> func)
        {
            _t = new Lazy<FluentBuilderGeneratorTests.DTO.Thing>(func);
            _tIsSet = true;
            return this;
        }
        public ThingBuilder WithT(Action<FluentBuilderGeneratorTests.DTO.ThingBuilder> action, bool useObjectInitializer = true) => WithT(() =>
        {
            var builder = new FluentBuilderGeneratorTests.DTO.ThingBuilder();
            action(builder);
            return builder.Build(useObjectInitializer);
        });

        private bool _Constructor_759650433_IsSet;
        private Lazy<FluentBuilderGeneratorTests.DTO.Thing> _Constructor_759650433 = new Lazy<FluentBuilderGeneratorTests.DTO.Thing>(() => new FluentBuilderGeneratorTests.DTO.Thing());
        public ThingBuilder UsingConstructor()
        {
            _Constructor_759650433 = new Lazy<FluentBuilderGeneratorTests.DTO.Thing>(() =>
            {
                return new FluentBuilderGeneratorTests.DTO.Thing
                (

                );
            });
            _Constructor_759650433_IsSet = true;

            return this;
        }


        public override Thing Build() => Build(true);

        public override Thing Build(bool useObjectInitializer)
        {
            if (Instance?.IsValueCreated != true)
            {
                Instance = new Lazy<Thing>(() =>
                {
                    Thing instance;
                    if (useObjectInitializer)
                    {
                        instance = new Thing
                        {
                            T = _t.Value
                        };

                        return instance;
                    }

                    if (_Constructor_759650433_IsSet) { instance = _Constructor_759650433.Value; }
                    else { instance = Default(); }

                    if (_tIsSet) { instance.T = _t.Value; }

                    return instance;
                });
            }

            PostBuild(Instance.Value);

            return Instance.Value;
        }

        public static Thing Default() => new Thing();

    }
}
#nullable disable