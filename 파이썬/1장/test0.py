print('*' * 20)
print('안녕하세요~')
print('저는 최해성입니다')
print('경남정보대학교 컴퓨터학과 1학년 B반 입니다.')
print('*' * 20)
print(9//3)
print(9%3)
print('17!')

name = '전우치'
age = 27
height = 179
sum = 10 + 20
muit = 10 * 20

print('나의 이름은 :', name)
print('나의 나이는 :', age)
print('나의 키는', height, 'cm입니다.')
print('10 + 20 =', sum)
print('10* 20 =', muit)

age = input('나이를 입력하세요')
if int(age) < 19:
    print('할인되었습니다.')
else:
    print