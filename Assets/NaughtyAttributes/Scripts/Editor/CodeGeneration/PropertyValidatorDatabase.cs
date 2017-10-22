// This class is auto generated

using System;
using System.Collections.Generic;

namespace NaughtyAttributes.Editor
{
    public static class PropertyValidatorDatabase
    {
        private static Dictionary<Type, PropertyValidator> validatorsByAttributeType;

        static PropertyValidatorDatabase()
        {
            validatorsByAttributeType = new Dictionary<Type, PropertyValidator>();
            validatorsByAttributeType[typeof(MaxValueAttribute)] = new MaxValuePropertyValidator();
validatorsByAttributeType[typeof(MinValueAttribute)] = new MinValuePropertyValidator();
validatorsByAttributeType[typeof(RequiredAttribute)] = new RequiredPropertyValidator();

        }

        public static PropertyValidator GetValidatorForAttribute(Type attributeType)
        {
            PropertyValidator validator;
            if (validatorsByAttributeType.TryGetValue(attributeType, out validator))
            {
                return validator;
            }
            else
            {
                return null;
            }
        }

        public static void ClearCache()
        {
            foreach (var kvp in validatorsByAttributeType)
            {
                kvp.Value.ClearCache();
            }
        }
    }
}
