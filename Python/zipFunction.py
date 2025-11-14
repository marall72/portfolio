# Enter your code here. Read input from STDIN. Print output to STDOUT
nAndx = input().split(" ")

subjectScores = []
for i in range(int(nAndx[1])):
    scores = input().split(" ")
    scoreBundle = []
    for score in scores:
        scoreBundle.append(int(score))

    subjectScores.append(scoreBundle)
    
print(subjectScores)
student = zip(*subjectScores)
for i in student:
    sumOf = sum(i)
    average = sumOf / int(nAndx[1])
    print(average)