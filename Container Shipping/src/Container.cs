using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaurensKruis.ContainerShipping
{
    public class Container
    {
        public const float MaxWeight = 3f;
        public const float MinWeight = 0.4f;

        [Flags]
        public enum Type
        {
            Cooled,
            Valuable
        }


        private float weight = MinWeight;
        public float Weight
        {
            get => weight;
            set => weight = Math.Clamp(value, MinWeight, MaxWeight);
        }

        public Type type;
    }
}