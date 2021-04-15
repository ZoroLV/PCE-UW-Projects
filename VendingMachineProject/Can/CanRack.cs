// Excercise 03
//Author: Jensen, Luke

using Can;
using System;
using System.Diagnostics;

namespace Exercise03
{
    public class CanRack
    {
        private const int EMPTYBIN = 0;
        private const int BINSIZE = 3;

        private int regular = EMPTYBIN;
        private int orange = EMPTYBIN;
        private int lemon = EMPTYBIN;

        private const int DUMMYARGUMENT = 0;

        public CanRack()
        {
            FillTheCanRack();
        }

        public void AddACanOf(string FlavorOfCanToBeAdded)
        {
            FlavorOfCanToBeAdded = FlavorOfCanToBeAdded.ToUpper();
            Debug.WriteLine("adding a can of {0} flavored soda to the rack", FlavorOfCanToBeAdded);
            if (FlavorOfCanToBeAdded == "REGULAR") regular = regular + 1;
            else if (FlavorOfCanToBeAdded == "ORANGE") orange = orange + 1;
            else if (FlavorOfCanToBeAdded == "LEMON") lemon = lemon + 1;
            else Debug.WriteLine("Error: attempt to add unknownflavor {0}", FlavorOfCanToBeAdded);
        }

        public void AddACanOf(Flavor FlavorOfCanToBeAdded)
        {
            AddACanOf(FlavorOfCanToBeAdded.ToString());
        }

        public void RemoveACanOf(string FlavorOfCanToBeRemoved)
        {
            FlavorOfCanToBeRemoved = FlavorOfCanToBeRemoved.ToUpper();
            Debug.WriteLine("removing a can of {0} flavored soda to the rack", FlavorOfCanToBeRemoved);
            if (FlavorOfCanToBeRemoved == "REGULAR") regular = regular - 1;
            else if (FlavorOfCanToBeRemoved == "ORANGE") orange = orange - 1;
            else if (FlavorOfCanToBeRemoved == "LEMON") lemon = lemon - 1;
            else Debug.WriteLine("Error: attempt to remove unknown flavor {0}", FlavorOfCanToBeRemoved);
        }

        public void RemoveACanOf(Flavor FlavorOfCanToBeRemoved)
        {
            AddACanOf(FlavorOfCanToBeRemoved.ToString());
        }

        public void FillTheCanRack()
        {
            Debug.WriteLine("Filling the can rack");
            regular = BINSIZE;
            orange = BINSIZE;
            lemon = BINSIZE;
        }

        public void EmptyCanRackOf(string FlavorOfBinToBeEmptied)
        {
            FlavorOfBinToBeEmptied = FlavorOfBinToBeEmptied.ToUpper();
            Debug.WriteLine("Emptying can rack of flavor {0}", FlavorOfBinToBeEmptied);
            if (FlavorOfBinToBeEmptied == "REGULAR") regular = EMPTYBIN;
            else if (FlavorOfBinToBeEmptied == "ORANGE") orange = EMPTYBIN;
            else if (FlavorOfBinToBeEmptied == "LEMON") lemon = EMPTYBIN;
            else Debug.WriteLine("Error: attempt to empty rack of unkown flavor {0}", FlavorOfBinToBeEmptied);
        }

        public void EmptyCanRackOf(Flavor FlavorOfCanToBeEmptied)
        {
            AddACanOf(FlavorOfCanToBeEmptied.ToString());
        }
    }
}