class Solution:
    def countPrimes(self, n: int) -> int:
        answer = 0
        a = [1] * n 
        for i in range (2, n):
            if a[i] == 1:
                answer+=1
                for k in range (i, n, i):
                    a[k] = 0
        return answer
