'''
Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".
'''


class Solution:
    def longestCommonPrefix(self, strs: List[str]) -> str:
        if len(strs) == 1:
            return ''.join(strs[0])

        prefix = []
        for i, j in zip(strs[0], strs[1]):
            if i == j:
                prefix.append(i)
            else:
                break
        strs[1] = prefix
        return Solution.longestCommonPrefix(self, strs[1:])
