using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWarsC.Challenges
{
    /*
     Description
        Middle Earth is about to go to war. The forces of good will have many battles
        with the forces of evil. Different races will certainly be involved. Each race 
        has a certain worth when battling against others. On the side of good we have 
        the following races, with their associated worth:
        Hobbits: 1
        Men: 2
        Elves: 3
        Dwarves: 3
        Eagles: 4
        Wizards: 10
        On the side of evil we have:
        Orcs: 1
        Men: 2
        Wargs: 2
        Goblins: 2
        Uruk Hai: 3
        Trolls: 5
        Wizards: 10
        Although weather, location, supplies and valor play a part in any battle, 
        if you add up the worth of the side of good and compare it with the worth 
        of the side of evil, the side with the larger worth will tend to win.
        Thus, given the count of each of the races on the side of good, followed 
        by the count of each of the races on the side of evil, determine which side wins.
        Input:
        The function will be given two parameters. Each parameter will be a string 
        separated by a single space. Each string will contain the count of each race on the side of good and evil.
        The first parameter will contain the count of each race on the side of good in the following order:
        Hobbits, Men, Elves, Dwarves, Eagles, Wizards.
        The second parameter will contain the count of each race on the side of evil in the following order:
        Orcs, Men, Wargs, Goblins, Uruk Hai, Trolls, Wizards.
        All values are non-negative integers. The resulting sum of the worth for each
        side will not exceed the limit of a 32-bit integer.

        Output:
        Return "Battle Result: Good triumphs over Evil" if good wins, "Battle Result: 
        Evil eradicates all trace of Good" if evil wins, or "Battle Result: No victor on this battle field" if it ends in a tie.
         */
    class GoodVsEvil
    {
        //first dirty implementation
        public static string Battle(string good, string evil)
        {
            string goods = "Battle Result: Good triumphs over Evil";
            string bads = "Battle Result: Evil eradicates all trace of Good";
            string tie = "Battle Result: No victor on this battle field";
            int goodsScore = 0;
            int badScore = 0;
            int[] goodPower = new int[] { 1,2,3,3,4,10};
            int[] badPower = new int[] { 1, 2, 2, 2, 3, 5,10 };
            string[] goodsQuantity = good.Split(" ");
            string[] badsQuantity = evil.Split(" ");

            for (int i = 0; i < goodsQuantity.Length; i++)
            {
                goodsScore += goodPower[i] * Int32.Parse(goodsQuantity[i]);
            }
            for (int i = 0; i < badsQuantity.Length; i++)
            {
                badScore += badPower[i] * Int32.Parse(badsQuantity[i]);
            }

            if (goodsScore > badScore)
            {
                return goods;
            } else if(goodsScore == badScore)
            {
                return tie;
            } else
            {
                return bads;
            }
        }

        //improvement by ahamidou
        public static string GoodVsEvil1(string good, string evil)
        {
            var gWorth = new[] { 1, 2, 3, 3, 4, 10 };
            var eWorth = new[] { 1, 2, 2, 2, 3, 5, 10 };
            var g = good.Split(' ').Select(int.Parse).Zip(gWorth, (f, s) => f * s).Sum();
            var b = evil.Split(' ').Select(int.Parse).Zip(eWorth, (f, s) => f * s).Sum();
            return (g > b) ? "Battle Result: Good triumphs over Evil" : ((g == b) ? "Battle Result: No victor on this battle field" : "Battle Result: Evil eradicates all trace of Good");
        }
    }
}
