namespace AdventOfCode;

public class Day_01 : BaseDay
{
    private readonly int[] _input;

    public Day_01()
    {
        _input = File.ReadAllLines(InputFilePath).Select(int.Parse).ToArray();
    }

    public override ValueTask<string> Solve_1(){      
        var result = 0;
        
        for(int i = 1; i < _input.Length; ++i){
            if(_input[i] > _input[i - 1]){
                result++;
            }
        }

        return new(result.ToString());
    }        

    public override ValueTask<string> Solve_2(){
        var result = 0;

        for(int i = 1; i < _input.Length - 2; ++i){
            if(GetThreeMeasurementSum(i) > GetThreeMeasurementSum(i - 1)){
                result++;
            }
        }

        return new(result.ToString());
    }

    private int GetThreeMeasurementSum(int baseIndex){
        return _input[baseIndex] + _input[baseIndex + 1] + _input[baseIndex + 2];
    }
}
