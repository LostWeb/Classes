using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hookah
{
    /// <summary>
    /// Заказ
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Крепость кальяна
        /// </summary>
        public Strength Strength { get; set; }
        /// <summary>
        /// Вид табака
        /// </summary>
        public Tobaco Tobaco { get; set; }
        /// <summary>
        /// Способ забивки кальяна
        /// </summary>
        public Type Type { get; set; }
        /// <summary>
        /// Цена
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Кальянщик
        /// </summary>
        public Employee Employee { get; set; }
    }

    public enum Strength { light, middle, heavy }
    public enum Tobaco { ALFAKHER, NAKHLA, AFZAL, ADALYA, SERBETLI, DARKSIDE, TANGIERS }
    public enum Type { milk, fruits, mint }
}
