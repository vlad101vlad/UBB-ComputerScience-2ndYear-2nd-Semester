import time
from random import randint
from Domain.Drone import Drone

import pygame

from Domain.constants import *


def dummysearch():
    # example of some path in test1.map from [5,7] to [7,11]
    return [[5, 7], [5, 8], [5, 9], [5, 10], [5, 11], [6, 11], [7, 11]]


def displayWithPath(image, path, endCoordinates):
    mark = pygame.Surface((20, 20))
    mark.fill(GREEN)
    for move in path:
        image.blit(mark, (move[1] * 20, move[0] * 20))

    newMark = pygame.Surface((20, 20))
    newMark.fill(RED)

    image.blit(newMark, (endCoordinates[1] * 20, endCoordinates[0] * 20))
    return image


def getRandomCoordinates():
    randomX = randint(0, 19)
    randomY = randint(0, 19)
    return [randomX, randomY]


def showInformation(searchType, path, executionTime):
    if searchType == GREEDY:
        print("Greedy search is done:")
    if searchType == A_STAR:
        print("A* search is done:")

    print("Found path?: " + str(path[1]))
    print("Execution time: " + str(executionTime))


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
        coordinates = getRandomCoordinates()

        # create drona
        self._drone = Drone(coordinates[0], coordinates[1])

    def startGame(self, searchType):
        print("The game has started!\n")
        droneMap = self._mapRepository.getMap()

        self.initializePygame()

        # The drone can't start on brick squares
        self.initializeDrone()
        while droneMap.surface[self._drone.x][self._drone.y] == 1:
            self.initializeDrone()

        startCoordinates = [self._drone.x, self._drone.y]

        # End coordinates cannot be bricks
        endCoordinates = getRandomCoordinates()
        while droneMap.surface[endCoordinates[0]][endCoordinates[1]] == 1:
            endCoordinates = getRandomCoordinates()

        screen = pygame.display.set_mode((400, 400))
        screen.fill(WHITE)

        # define a variable to control the main loop
        running = True

        print("Start coordinates: " + str(startCoordinates))
        print("End coordinates" + str(endCoordinates))
        # main loop
        while running:
            # event handling, gets all event from the event queue
            for event in pygame.event.get():
                # only do something if the event is of type QUIT
                if event.type == pygame.QUIT:
                    # change the value to False, to exit the main loop
                    running = False

                # if event.type == pygame.KEYDOWN:
                #     self._drone.move(droneMap)  # this call will be erased

            screen.blit(self._drone.mapWithDrone(droneMap.image()), (0, 0))
            pygame.display.flip()

        startTime = time.time()

        if searchType == GREEDY:
            path = self._drone.greedySearch(startCoordinates, endCoordinates, droneMap)

        if searchType == A_STAR:
            path = self._drone.aStarSearch(startCoordinates, endCoordinates, droneMap)

        endTime = time.time()
        executionTime = endTime - startTime

        showInformation(searchType, path, executionTime)
        screen.blit(displayWithPath(droneMap.image(), path[0], endCoordinates), (0, 0))

        pygame.display.flip()
        time.sleep(5)
        pygame.quit()
