﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokermon
{
    public class Poker
    {
        public enum HandRank
        {
            FiveOfAKind = 0,
            StraightFlush = 1,
            FourOfAKind = 2,
            FullHouse = 3,
            Flush = 4,
            Straight = 5,
            ThreeOfAKind = 6,
            TwoPair = 7,
            OnePair = 8,
            Nothing = 9
        }

        public string BestHands(string[] hands)
        {
            if(hands.Length < 1)
                throw new ArgumentException();
            else if (hands.Length == 1)
                return hands[0];

            HandRank handRank0 = HandRank.Nothing;
            HandRank handRank1 = HandRank.Nothing;

         
            handRank0 = DetermineHand(hands[0]);
            handRank1 = DetermineHand(hands[1]);

            if (handRank0 == handRank1)
                return "TIE";
            else if (handRank0 < handRank1)
                return hands[0];
            else
                return hands[1];

        }


        public HandRank DetermineHand(string pokerHand)
        {
            // MUST REMAIN IN ORDER, BEST TO WORST FOR SHORT CIRCUIT TO WORK   
            if(IsFourOfAKind(pokerHand))
                return HandRank.FourOfAKind;
            if(IsThreeOfAKind(pokerHand))
                return HandRank.ThreeOfAKind;
            else if (IsTwoPair(pokerHand))
                return HandRank.TwoPair;
            else if(IsOnePair(pokerHand))
                return HandRank.OnePair;
            

            return HandRank.Nothing;

        }

        private bool IsOnePair(string hand)
        {
            string[] cards = hand.Split(' ');
            bool result = false;
            Dictionary<char, int> cardRankToCountMap = new Dictionary<char, int>();
            foreach (var card in cards)
            {
                if (cardRankToCountMap.ContainsKey(card[0]))
                    cardRankToCountMap[card[0]]++;
                else
                    cardRankToCountMap.Add(card[0], 1);
            }

            if (cardRankToCountMap.Any(x => x.Value == 2))
                result = true;

            return result;
        }

        private bool IsTwoPair(string hand)
        {
            string[] cards = hand.Split(' ');
            bool result = false;
            Dictionary<char, int> cardRankToCountMap = new Dictionary<char, int>();
            foreach (var card in cards)
            {
                if (cardRankToCountMap.ContainsKey(card[0]))
                    cardRankToCountMap[card[0]]++;
                else
                    cardRankToCountMap.Add(card[0], 1);
            }
            
            if (cardRankToCountMap.Where(x=>x.Value == 2).Count() == 2)
                result = true;

            return result;
        }



        public bool IsFourOfAKind(string hand)
        {
            string[] cards = hand.Split(' ');
            bool result = false;
            Dictionary<char, int> cardRankToCountMap = new Dictionary<char, int>();
            foreach (var card in cards)
            {
                if (cardRankToCountMap.ContainsKey(card[0]))
                    cardRankToCountMap[card[0]]++;
                else
                    cardRankToCountMap.Add(card[0], 1);
            }

            if (cardRankToCountMap.Any(x => x.Value == 4))
                result = true;

            return result;

        }

        public bool IsThreeOfAKind(string hand)
        {
            string[] cards = hand.Split(' ');
            bool result = false;
            Dictionary<char, int> cardRankToCountMap = new Dictionary<char, int>();
            foreach (var card in cards)
            {
                if (cardRankToCountMap.ContainsKey(card[0]))
                    cardRankToCountMap[card[0]]++;
                else
                    cardRankToCountMap.Add(card[0], 1);
            }

            if (cardRankToCountMap.Any(x => x.Value == 3))
                result = true;

            return result;

        }

        public bool IsFiveOfAKind(string hand)
        {
            string[] cards = hand.Split(' ');
            bool result = false;
            Dictionary<char, int> cardRankToCountMap = new Dictionary<char, int>();
            foreach (var card in cards)
            {
                if (cardRankToCountMap.ContainsKey(card[0]))
                    cardRankToCountMap[card[0]]++;
                else
                    cardRankToCountMap.Add(card[0], 1);
            }

            if (cardRankToCountMap.Any(x => x.Value == 5))
                result = true;

            return result;

        }

        public bool IsStraight(string hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(string hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFullHouse(string hand)
        {
            throw new NotImplementedException();
        }

        public bool IsStraightFlush(string hand)
        {
            throw new NotImplementedException();
        }
        public bool IsRoyalFlush(string hand)
        {
            throw new NotImplementedException();
        }

    }
}
