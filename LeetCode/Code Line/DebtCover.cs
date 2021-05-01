using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Code_Line
{
    class DebtCover
    {
        public void DebtCoverMethod(int salary,int percentageLimit, float[] debtList, float[] interestList)
        {
            int totalPayment = 0;
            while (true)
            {
                int l = debtList.Length;
                float perMothPayment = (float)salary * ((float)percentageLimit / 100);
                float[] tempDebtListForSnowball = new float[l];
                float[] tempInterestListForSnowball = new float[l];
                float[] tempDebtListForAvalanche = new float[l];
                float[] tempInterestListForAvalanche = new float[l];

                Array.Copy(debtList, tempDebtListForSnowball, l);
                Array.Copy(interestList, tempInterestListForSnowball, l);
                Array.Copy(debtList, tempDebtListForAvalanche, l);
                Array.Copy(interestList, tempInterestListForAvalanche, l);

                tempDebtListForSnowball = SortMethod(tempDebtListForSnowball, tempInterestListForSnowball, 's');
                tempInterestListForAvalanche = SortMethod(tempDebtListForAvalanche, tempInterestListForAvalanche, 'a');

                ApplyPayments(tempDebtListForSnowball, tempInterestListForSnowball, perMothPayment);
                ApplyPayments(tempDebtListForAvalanche, tempInterestListForAvalanche, perMothPayment);

                var nextSnowBallPayments = CalculateNextMonthPayments(tempDebtListForSnowball, tempInterestListForSnowball);

                var nextAvalanchePayments = CalculateNextMonthPayments(tempDebtListForAvalanche, tempInterestListForAvalanche);

                if(nextAvalanchePayments.Sum()==0)
                {
                    return;
                }
                if (nextSnowBallPayments.Sum() == 0)
                {
                    return;
                }
                if (nextSnowBallPayments.Sum()>=nextAvalanchePayments.Sum())
                {
                    debtList = nextSnowBallPayments;
                    interestList = tempInterestListForSnowball;
                }
                else
                {
                    debtList = nextAvalanchePayments;
                    interestList = tempInterestListForAvalanche;
                }
            }
        }

        public float[] CalculateNextMonthPayments(float[] debtList,float[] interestList)
        {
            for(int i=0;i<debtList.Length;i++)
            {
                debtList[i] = debtList[i] + (debtList[i] * interestList[i] / 100);
            }

            return debtList;
        }
        public void ApplyPayments(float[] debtList, float[] interestList,float payment)
        {
            for(int i=0;i<debtList.Length;i++)
            {
                if(debtList[i]>=payment)
                {
                    debtList[i] -= payment;
                    payment = 0;
                }
                else if(debtList[i]<payment)
                {
                    payment -= debtList[i];
                    debtList[i] = 0;
                }
                if(payment==0)
                {
                    break;
                }
            }
        }
        public float[] SortMethod(float[] debtList, float[] interestList,char sortkind)
        {
            Dictionary<int, float> dict = new Dictionary<int, float>();
            if(sortkind=='a')
            {
                for(int i=0;i<interestList.Length;i++)
                {
                    dict.Add(i, interestList[i]);
                }
                dict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                interestList = dict.Values.ToArray();

                float[] tempDebtList = new float[debtList.Length];
                Array.Copy(debtList,tempDebtList,debtList.Length);
                for(int i=0;i<interestList.Length;i++)
                {
                    debtList[i] = tempDebtList[dict.ElementAt(i).Key];
                }
                return interestList;
            }
            else if(sortkind=='s')
            {
                for (int i = 0; i < debtList.Length; i++)
                {
                    dict.Add(i, debtList[i]);
                }
                dict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                debtList = dict.Values.ToArray();

                float[] tempInterestList = new float[interestList.Length];
                Array.Copy(interestList, tempInterestList, debtList.Length);
                for (int i = 0; i < interestList.Length; i++)
                {
                    interestList[i] = tempInterestList[dict.ElementAt(i).Key];
                }
                return debtList;
            }
            return null;
             
        }
    }
}
