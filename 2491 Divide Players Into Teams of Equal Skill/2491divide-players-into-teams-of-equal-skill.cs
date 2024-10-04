public class Solution
{
    public long DividePlayers(int[] skill)
    {
        Array.Sort(skill);
        int first = 0;
        int last = skill.Length - 1;
        long chemistry = 0L;
        int teamSkill = skill[first] + skill[last];
        while (first < last)
        {
            if (skill[first] + skill[last] != teamSkill)
            {
                return -1;
            }
            chemistry += skill[first++] * skill[last--];
        }
        return chemistry;
    }
}