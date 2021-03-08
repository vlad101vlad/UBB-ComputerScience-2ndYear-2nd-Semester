from Service.Controller import Controller
from easygui import *
import time


class View:
    def __init__(self):
        self.service = Controller()

    def prepareMainMenu(self):
        choices = ["SUPER_FAST", "FAST", "NORMAL", "SLOW", "SNAIL"]
        return choicebox("ArtificialIntelligence - Lab1\n"
                         "Select the speed of the drone and press <OK> to start the game.\n"
                         "Press <Cancel> to close the game.", "Main menu", choices)

    def showMenu(self):
        userChoice = self.prepareMainMenu()
        if userChoice is not None:
            self.service.setDroneSpeed(userChoice)
            self.runGame()
            self.finishGameMessage()

    def runGame(self):
        self.service.startGame()

    def finishGameMessage(self):
        msgbox("The map is fully discovered!\n"
               "The game will automatically close in 3sec after you press ok", title="Game is over")
        time.sleep(3)
