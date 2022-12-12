using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LaurensKruis.ContainerShipping.src
{
    public static class Port
    {
        private enum Side : int
        {
            Left = -1,
            Right = 1
        }



        public static void LoadShip(Ship ship, IEnumerable<Container> containers)
        {

            
            containers = containers.OrderByDescending(containers => containers.Weight);

            
            
        }


        private static (IEnumerable<Container> left, IEnumerable<Container> right) Split(IEnumerable<Container> containers)
        {
            List<Container> containersLeft = new List<Container>();
            List<Container> containersRight = new List<Container>();

            foreach (var container in containers)
            {
                if (containersLeft.GetWeight() > containersRight.GetWeight())
                    containersRight.Add(container);
                else
                    containersLeft.Add(container);
            }

            return (containersLeft.AsReadOnly(), containersRight.AsReadOnly());
        }

        private static void FillSide(Ship ship, IEnumerable<Container> containers, Side side)
        {
            int direction = (int) side;

            
        }

        public static float GetWeight(this IEnumerable<Container> list) => list.Sum(container => container.Weight);
        
    }
}
