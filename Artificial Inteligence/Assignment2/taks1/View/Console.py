from Domain.constants import *

def printMenu():
    print("\nWelcome to the game!\nChoose one of the following:\n"
          "1. Greedy search path\n"
          "2. A* search path\n"
          "x - Exit the game.\n\n")


class Menu:
    def __init__(self, service):
        self._service = service

    def runMenu(self):
        while True:
            printMenu()
            choice = input("Choice:~ ")
            
            if choice == 'x':
                print("The game has been closed!\n")
                exit(0)

            if choice == '1':
                self._service.startGame(GREEDY)
            if choice == '2':
                self._service.startGame(A_STAR)
