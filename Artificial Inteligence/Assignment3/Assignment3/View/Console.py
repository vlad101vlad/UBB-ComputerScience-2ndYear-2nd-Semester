from Assignment3.View.ui import *
from Assignment3.View.MapChoices import *
from Assignment3.View.gui import *


class Console:
    def __init__(self, controller):
        self.controller = controller

    def runMenu(self):
        while True:
            printMenu()

            choice = input("Choice:~ ")
            if choice == 'x':
                exit(0)

            if choice == "1":
                self.mapOptions()
            if choice == "2":
                printEAOptions()

    def mapOptions(self):
        printMapOptions()
        choice = input("Choice:~ ")

        if choice == 'a':
            MapChoices.createRandomMap()
        if choice == 'b':
            mapName = input("--Map name:~ ")
            self.controller.loadNewMap(mapName)
        if choice == 'c':
            MapChoices.saveMap()
        if choice == 'd':
            self.initGUI()

    def initGUI(self):
        screen = initPyGame()
        currentMap = self.controller.getCurrentMap()
        resultingImage = image(currentMap)

        closePyGame(screen, resultingImage)
