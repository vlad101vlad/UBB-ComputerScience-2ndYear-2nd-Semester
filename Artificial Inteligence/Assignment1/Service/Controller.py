import pygame
import Domain.constants
import time
from Domain.Map import DMap
from Domain.Environment import Environment
from Domain.Drone import Drone
from Domain.constants import *

from random import randint


class Controller:
    def __init__(self):
        self.drone = None
        self.environment = None
        self.map = None
        self.screen = None

    def updateMap(self, pygameScreen, environment, detectedMap):
        detectedMap.markDetectedWalls(environment, self.drone.x, self.drone.y)
        pygameScreen.blit(detectedMap.image(self.drone.x, self.drone.y), (400, 0))
        pygame.display.flip()
        # Very IMPORTANT! If we don't include the event pump at each frame update, the app will not interact anymore
        # with the OS and it will think that this app is blocked , thus it will try to kill it.
        pygame.event.pump()

    def startGame(self):
        self.initGame()
        self.displayScreen()

        running = True
        while running:
            time.sleep(FAST)
            self.updateMap(self.screen, self.environment, self.map)
            self.drone.moveDFSIterative(self.map)

            if not self.drone.mainStack:
                # When we reach this point, in theory,
                # all the possible discovered blocks were parsed, thus we can exit the game
                self.drone.x = None
                self.drone.y = None
                # We set the drone coordinates to 'None as required'

                break
        pygame.quit()

    def displayScreen(self):
        screen = pygame.display.set_mode((800, 400))
        screen.fill(WHITE)
        screen.blit(self.environment.image(), (0, 0))
        self.screen = screen

    def initGame(self):
        self.environment = self.initEnvironment()
        self.map = self.initMap()
        self.initPygame()
        self.drone = self.initDrone()

    def initPygame(self):
        pygame.init()
        # load and set the logo
        logo = pygame.image.load("logo32x32.png")
        pygame.display.set_icon(logo)
        pygame.display.set_caption("Drone Exploration")

    # Initialise the 3 main entities
    def initMap(self):
        return DMap()

    def initEnvironment(self):
        environment = Environment()
        environment.loadEnvironment("test2.map")
        return environment

    def initDrone(self):
        # Fixed bug, sometimes the drone is spawn in a location which there was a brick
        environmentSurface = self.environment.getSurface()
        # we position the drone somewhere in the area
        x = randint(0, 19)
        y = randint(0, 19)
        while environmentSurface[x][y] == BRICK:
            # When the random position of the drone is a brick, we generate another random position
            x = randint(0, 19)
            y = randint(0, 19)
            # cream drona
        drone = Drone(x, y)
        return drone


