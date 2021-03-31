from Assignment3.View.ui import *


class Console:
    def __init__(self):
        pass

    def runMenu(self):
        while True:
            printMenu()

            choice = input("Choice:~ ")
            if choice == 'x':
                exit(0)

            if choice == "1":
                printMapOptions()
            if choice == "2":
                printEAOptions()
