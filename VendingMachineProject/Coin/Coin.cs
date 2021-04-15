using System;

namespace Coin
{
    class Coin
    {

        private Denomination coinObject;
        public enum Denomination { SLUG = 0, NICKEL = 5, DIME = 10, QUARTER = 25, HALFDOLLAR = 50 }

        public Coin()
        {
            coinObject = Denomination.SLUG;
        }

        public Coin(Denomination CoinEnumeral)
        {
            coinObject = CoinEnumeral;
        }

        public Coin(string CoinName)
        {
            Denomination coinEnumeral;
            if (Enum.IsDefined(typeof(Denomination),CoinName) &&
                Enum.TryParse<Denomination>(CoinName, out coinEnumeral))
            {

                coinObject = coinEnumeral;
            }
            else
            {
                coinObject = Coin.Denomination.SLUG;
            }
        }

        public Coin(decimal CoinValue)
        {
            Denomination castFromValue = (Denomination)(CoinValue * 100);
            switch (castFromValue)
            {
                case Denomination.NICKEL:
                case Denomination.DIME:
                case Denomination.QUARTER:
                case Denomination.HALFDOLLAR:
                    coinObject = castFromValue;
                    break;
                default:
                    coinObject = Denomination.SLUG;
                    break;
            }
        }

        public decimal ValueOf
        {
            get
            {
                return (decimal)coinObject / 100M;
            }
        }

        public Denomination CoinEnumeral
        {
            get
            {
                return coinObject;
            }
        }

        public override string ToString()
        {
            return Enum.GetName(typeof(Denomination), coinObject);
        }
    }
}
