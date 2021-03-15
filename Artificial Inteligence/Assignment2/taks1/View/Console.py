class Menu:
    def __init__(self, service):
        self._service = service

    def printMenu(self):
        print("\nWelcome to the game!\nChoose one of the following:\n"
              "1. Start the game\n"
              "x - Exit the game.\n\n")

    def runMenu(self):
        while True:
            self.printMenu()
            choice = input("Choice:~ ")
            
            if choice == 'x':
                print("The game has been closed!\n")
                exit(0)
            
            if choice == '1':
                self._service.startGame()
