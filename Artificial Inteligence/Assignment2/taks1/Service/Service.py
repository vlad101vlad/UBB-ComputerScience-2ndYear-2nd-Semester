import time
from random import randint
from Domain.Drone import Drone

import pygame

from Domain.constants import *


def dummysearch():
    # example of some path in test1.map from [5,7] to [7,11]
    return [[5, 7], [5, 8], [5, 9], [5, 10], [5, 11], [6, 11], [7, 11]]


def displayWithPath(image, path):
    mark = pygame.Surface((20, 20))
    mark.fill(GREEN)
    for move in path:
        image.blit(mark, (move[1] * 20, move[0] * 20))

    return image


class Service:
    def __init__(self, mapRepository):
        self._mapRepository = mapRepository
        self._drone = None

    def initializePygame(self):
        pygame.init()

        logo = pygame.image.load("logo32x32.png")
        pygame.display.set_icon(logo)
        pygame.display.set_caption("Path in simple environment")

    def initializeDrone(self):
        # we position the drone somewhere in the area
        x = randint(0, 19)
        y = randint(0, 19)

        # create drona
        self._drone = Drone(x, y)

    def startGame(self):
        print("The game has started!\n")
        self.initializePygame()
        self.initializeDrone()

        screen = pygame.display.set_mode((400, 400))
        screen.fill(WHITE)

        droneMap = self._mapRepository.getMap()
        # define a variable to control the main loop
        running = True

        # main loop
        while running:
            # event handling, gets all event from the event queue
            for event in pygame.event.get():
                # only do something if the event is of type QUIT
                if event.type == pygame.QUIT:
                    # change the value to False, to exit the main loop
                    running = False

                if event.type == pygame.KEYDOWN:
                    self._drone.move(droneMap)  # this call will be erased

            screen.blit(self._drone.mapWithDrone(droneMap.image()), (0, 0))
            pygame.display.flip()

        path = dummysearch()
        screen.blit(displayWithPath(droneMap.image(), path), (0, 0))

        pygame.display.flip()
        time.sleep(5)
        pygame.quit()
