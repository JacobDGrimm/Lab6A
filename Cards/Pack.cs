using System;

namespace Cards
{	
	class Pack
	{
        public const int NumSuits = 4;
        public const int CardsPerSuit = 13;
        private PlayingCard[,] cardPack;
        private Random randomCardSelector = new Random();

        public Pack()
        {
            this.cardPack = new PlayingCard[NumSuits, CardsPerSuit];
            for(Suit suit = Suit.Clubs; suit <= Suit.Spades; suit++)
            {
                for (Value value = Value.Two; value <= Value.Ace; value ++)
                {
                    this,cardPack[(int)suit, (int)value] = new PlayingCard(suit, value);
                }
            }
        }

        public PlayingCard DealCardFromPack()
        {
            Suit suit = (Suit)randomCardSelector.Next(NumSuits);
            while (this.IsSuitEmpty(suit))
            {
                suit = (Suit)randomCardSelector.Next(NumSuits);
            }
            Value value = (Value)randomCardSelector.Next(CardsPerSuit);
            while (this.IsCardAlreadyDealt(suit, value))
            {
                value = (Value)randomCardSelector.Next(CardsPerSuit);
            }
        }

        private bool IsSuitEmpty(Suit suit)
        {
            // TODO: return true if there are no more cards available in this suit
            throw new NotImplementedException("IsSuitEmpty - TBD");
        }

        private bool IsCardAlreadyDealt(Suit suit, Value value)
        {
            // TODO: return true if this card has already been dealt   
            throw new NotImplementedException("IsCardAlreadyDealt - TBD");
        }
    }
}