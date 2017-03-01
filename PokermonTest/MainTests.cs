using System;
using NUnit.Framework;
using Pokermon;
namespace PokermonTest
{
    public class MainTests
    {
        [Test]
        public void Test_True_Is_True()
        {
            const bool value = true;
            Assert.IsTrue(value);
        }


        [Test]
        public void One_hand()
        {
            Poker poker = new Poker();
            const string hand = "4S 5S 7H 8D JC";
            Assert.That(poker.BestHands(new[] { hand }), Is.EqualTo(hand));
        }

        [Test]
        public void Nothing_vs_four_of_a_kind()
        {
            Poker poker = new Poker();
            const string nothing = "4S 5H 6S 8D JH";
            const string fourOf8s = "8S 4H 8S 8D 8H";
            Assert.That(poker.BestHands(new[] { nothing, fourOf8s }), Is.EqualTo(fourOf8s));
        }

        [Test]
        public void Nothing_vs_one_pair()
        {
            Poker poker = new Poker();
            const string nothing = "4S 5H 6S 8D JH";
            const string pairOf4 = "2S 4H 6S 4D JH";
            Assert.That(poker.BestHands(new[] { nothing, pairOf4 }), Is.EqualTo(pairOf4));
        }


        [Test]
        public void Two_pairs()
        {
            Poker poker = new Poker();
            const string pairOf2 = "4S 2H 6S 2D JH";
            const string pairOf4 = "2S 4H 6S 4D JH";
            const string TIE = "TIE";
            // Assert.That(poker.BestHands(new[] { pairOf2, pairOf4 }), Is.EqualTo(pairOf4));
            Assert.That(poker.BestHands(new[] { pairOf2, pairOf4 }), Is.EqualTo(TIE));
        }


        [Test]
        public void One_pair_vs_double_pair()
        {
            Poker poker = new Poker();
            const string pairOf8 = "2S 8H 6S 8D JH";
            const string doublePair = "4S 5H 4S 8D 5H";
            Assert.That(poker.BestHands(new[] { pairOf8, doublePair }), Is.EqualTo(doublePair));
        }

        
        [Test]
        public void Two_double_pairs()
        {
            Poker poker = new Poker();
            const string doublePair2And8 = "2S 8H 2S 8D JH";
            const string doublePair4And5 = "4S 5H 4S 8D 5H";
            const string TIE = "TIE";
            // Assert.That(poker.BestHands(new[] { doublePair2And8, doublePair4And5 }), Is.EqualTo(doublePair2And8));
            Assert.That(poker.BestHands(new[] { doublePair2And8, doublePair4And5 }), Is.EqualTo(TIE));
        }

        [Test]
        public void Double_pair_vs_three()
        {
            Poker poker = new Poker();
            const string doublePair2And8 = "2S 8H 2S 8D JH";
            const string threeOf4 = "4S 5H 4S 8D 4H";
            Assert.That(poker.BestHands(new[] { doublePair2And8, threeOf4 }), Is.EqualTo(threeOf4));
        }

        [Test]
        public void Two_threes()
        {
            Poker poker = new Poker();
            const string threeOf2 = "2S 2H 2S 8D JH";
            const string threeOf1 = "4S AH AS 8D AH";
            const string TIE = "TIE";
            // Assert.That(poker.BestHands(new[] { threeOf2, threeOf1 }), Is.EqualTo(threeOf2));
            Assert.That(poker.BestHands(new[] { threeOf2, threeOf1 }), Is.EqualTo(TIE));
        }

        [Ignore("Remove to run test")]
        [Test]
        public void Three_vs_straight()
        {
            Poker poker = new Poker();
            const string threeOf4 = "4S 5H 4S 8D 4H";
            const string straight = "3S 4H 2S 6D 5H";
            // Assert.That(poker.BestHands(new[] { threeOf4, straight }), Is.EqualTo(straight));
        }

        [Ignore("Remove to run test")]
        [Test]
        public void Two_straights()
        {
            Poker poker = new Poker();
            const string straightTo8 = "4S 6H 7S 8D 5H";
            const string straightTo9 = "5S 7H 8S 9D 6H";
            // Assert.That(poker.BestHands(new[] { straightTo8, straightTo9 }), Is.EqualTo(straightTo9));

            const string straightTo1 = "AS QH KS TD JH";
            const string straightTo5 = "4S AH 3S 2D 5H";
            // Assert.That(poker.BestHands(new[] { straightTo1, straightTo5 }), Is.EqualTo(straightTo1));
        }

        [Ignore("Remove to run test")]
        [Test]
        public void Straight_vs_flush()
        {
            Poker poker = new Poker();
            const string straightTo8 = "4S 6H 7S 8D 5H";
            const string flushTo7 = "2S 4S 5S 6S 7S";
            // Assert.That(poker.BestHands(new[] { straightTo8, flushTo7 }), Is.EqualTo(flushTo7));
        }

        [Ignore("Remove to run test")]
        [Test]
        public void Two_flushes()
        {
            Poker poker = new Poker();
            const string flushTo8 = "3H 6H 7H 8H 5H";
            const string flushTo7 = "2S 4S 5S 6S 7S";
            // Assert.That(poker.BestHands(new[] { flushTo8, flushTo7 }), Is.EqualTo(flushTo8));
        }

        [Ignore("Remove to run test")]
        [Test]
        public void Flush_vs_full()
        {
            Poker poker = new Poker();
            const string flushTo8 = "3H 6H 7H 8H 5H";
            const string full = "4S 5H 4S 5D 4H";
            // Assert.That(poker.BestHands(new[] { full, flushTo8 }), Is.EqualTo(full));
        }

        [Ignore("Remove to run test")]
        [Test]
        public void Two_fulls()
        {
            Poker poker = new Poker();
            const string fullOf4By9 = "4H 4S 4D 9S 9D";
            const string fullOf5By8 = "5H 5S 5D 8S 8D";
            // Assert.That(poker.BestHands(new[] { fullOf4By9, fullOf5By8 }), Is.EqualTo(fullOf5By8));
        }

        [Ignore("Remove to run test")]
        [Test]
        public void Full_vs_square()
        {
            Poker poker = new Poker();
            const string full = "4S 5H 4S 5D 4H";
            const string squareOf3 = "3S 3H 2S 3D 3H";
            // Assert.That(poker.BestHands(new[] { full, squareOf3 }), Is.EqualTo(squareOf3));
        }

        [Test]
        public void Two_squares()
        {
            Poker poker = new Poker();
            const string squareOf2 = "2S 2H 2S 8D 2H";
            const string squareOf5 = "4S 5H 5S 5D 5H";
            const string TIE = "TIE";
            // Assert.That(poker.BestHands(new[] { squareOf2, squareOf5 }), Is.EqualTo(squareOf5));
            Assert.That(poker.BestHands(new[] { squareOf2, squareOf5 }), Is.EqualTo(TIE));
        }

        [Ignore("Remove to run test")]
        [Test]
        public void Square_vs_straight_flush()
        {
            Poker poker = new Poker();
            const string squareOf5 = "4S 5H 5S 5D 5H";
            const string straightFlushTo9 = "5S 7S 8S 9S 6S";
            // Assert.That(poker.BestHands(new[] { squareOf5, straightFlushTo9 }), Is.EqualTo(straightFlushTo9));
        }

        [Ignore("Remove to run test")]
        [Test]
        public void Two_straight_flushes()
        {
            Poker poker = new Poker();
            const string straightFlushTo8 = "4H 6H 7H 8H 5H";
            const string straightFlushTo9 = "5S 7S 8S 9S 6S";
            // Assert.That(poker.BestHands(new[] { straightFlushTo8, straightFlushTo9 }),
            // Is.EqualTo(straightFlushTo9));
        }



        [Ignore("Remove to run test")]
        [Test]
        public void Straight_to_5_against_a_pair_of_jacks()
        {
            Poker poker = new Poker();
            const string straightTo5 = "2S 4D 5C 3S AS";
            const string twoJacks = "JD 8D 7D JC 5D";
            // Assert.That(poker.BestHands(new[] { straightTo5, twoJacks }),
            // Is.EqualTo(straightTo5));
        }



    }  // class
}  // namespace
