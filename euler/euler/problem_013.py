import math

fname = "D:\PROJECTS\Project_Euler\euler\euler\problem_013.in"

with open(fname) as f:
    listlongs = f.readlines()
# you may also want to remove whitespace characters like `\n` at the end of each line
listlongs = [int(x.strip()) for x in listlongs]
sum = 0


for i in listlongs:
    sum += i

sum = str(sum)
sum = sum[:10]
print(sum)