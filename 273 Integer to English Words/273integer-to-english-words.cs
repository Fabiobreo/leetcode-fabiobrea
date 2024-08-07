public class Solution {

    private Dictionary<int, string> wordMap = new Dictionary<int, string>()
    {
        {0, "Zero"}, {1, "One"}, {2, "Two"}, {3, "Three"}, {4, "Four"},
        {5, "Five"}, {6, "Six"}, {7, "Seven"}, {8, "Eight"}, {9, "Nine"},
        {10, "Ten"}, {11, "Eleven"}, {12, "Twelve"}, {13, "Thirteen"}, {14, "Fourteen"},
        {15, "Fifteen"}, {16, "Sixteen"}, {17, "Seventeen"}, {18, "Eighteen"}, {19, "Nineteen"},
        {20, "Twenty"}, {30, "Thirty"}, {40, "Forty"}, {50, "Fifty"}, {60, "Sixty"},
        {70, "Seventy"}, {80, "Eighty"}, {90, "Ninety"}
    };

    public string NumberToWords(int num)
    {
        if (num == 0)
        {
            return wordMap[num];
        }
        int hundreds = num % 1000;
        int rest = num / 1000;
        int thousands = rest % 1000;
        rest = rest / 1000;
        int millions = rest % 1000;
        int billions = rest / 1000;
        string result = billions > 0 ? $"{ThreeDigitsToWords(billions)} Billion " : "";
        result += millions > 0 ? $"{ThreeDigitsToWords(millions)} Million " : "";
        result += thousands > 0 ? $"{ThreeDigitsToWords(thousands)} Thousand " : "";
        result += hundreds > 0 ? $"{ThreeDigitsToWords(hundreds)}" : "";
        return result.Trim();
    }

    private string ThreeDigitsToWords(int num) 
    {
        int rest = num % 100;
        int hundreds = num / 100;
        string result = hundreds > 0 ? $"{wordMap[hundreds]} Hundred" : "";
        if (rest == 0)
        {
            return result;
        }
        else if(wordMap.ContainsKey(rest))
        {
            result += $" {wordMap[rest]}";
        }
        else
        {
            int units = rest % 10;
            int decs = rest / 10;
            result += decs > 0 ? $" {wordMap[decs * 10]}" : "";
            result += units > 0 ? $" {wordMap[units]}" : "";
        }
        return result.Trim();
    }
}