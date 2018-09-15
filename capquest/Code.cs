using System;

namespace capquest
{
    public class Code
    {
        public string calculate(double sum)
        {
            if(sum <= 0) return "Do not support this number";
            var baseNum = (sum%2 == 0) ? sum/2 : (sum+1)/2;
            var baseRange = 0.00;
            var getAnswer = false;
            while(baseNum > 0 && !getAnswer)
            {
                var simulationSum = sum;
                var simulationRange = baseNum;
                while(simulationSum > 0 && simulationRange > 0 && !getAnswer)
                {
                    simulationSum -= simulationRange;
                    simulationRange--;
                    if(simulationSum == 0){
                        baseRange = simulationRange + 1;
                        getAnswer = true;
                    }
                    else if(simulationSum < simulationRange) simulationSum = 0;
                }
                if(!getAnswer) baseNum--;
            }
            if(getAnswer)
            {
                var answer = "";
                for(var number = baseRange; number <= baseNum; number++)
                answer += $"{number} ";
                return answer.Trim();
            }else
                return $"only self is answer is {sum}";
        }
    }
}