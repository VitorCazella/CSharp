# GradeCalculator.py
#
# @ Author: Vitor Antunes Cazella
# Date: 04/03/2020
print("----------------------------------------------------\n")
project_score = int(input("Project Score: ").replace("%", ""))
exam_score = int(input("Exam Score: ").replace("%", ""))

total_score = (project_score + exam_score)/2

print("Overall Score: " + str(total_score) + "%\n")

if total_score >= 80:
    print("Grade: A")
elif total_score >= 70:
    print("Grade: B")
elif total_score >= 60:
    print("Grade: C")
elif total_score >= 50:
    print("Grade: D")
elif total_score < 50:
    print("Fail")
else:
    exit()


print("\n----------------------------------------------------")