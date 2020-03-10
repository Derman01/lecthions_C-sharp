def main():
    global popitka
    bik = 0
    korova = 0
    print("Попытка_", popitka)
    B = [int(s) for s in input().split()]
    if (B == A):
        win()
    else:
        for i in range(4):
            if (A[i] == B[i]):
                bik += 1
                korova -= 1
            for j in range(4):
                if (B[i] == A[j]):
                    korova +=1
        print("Быков: {0};   Коров: {1}".format(bik, korova))
        popitka += 1
        main()
def generation():
    global A
    A = [3, 8, 5, 4]
    #A = [-1]*4
    #from random import randint
    #for i in range(4):
    #    k = randint(0,9)
    #    while( k == A[0] or  k == A[1] or  k == A[2] or  k == A[3]):
    #        k = randint(0,9)
    #    A[i] = k
def win():
    print("__ПОБЕДА!__")
    input()
    import os
    os.system("cls")
    start()
def start():
    global popitka
    popitka = 1
    generation()
    main()

start()