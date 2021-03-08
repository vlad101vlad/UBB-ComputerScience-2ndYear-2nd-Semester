import pygame
from Domain.constants import *
import time
import sys


class Drone:
    def __init__(self, x, y):
        self.x = x
        self.y = y
        self.visitedCoords = []
        self.stackNextCoordToVisit = []
        self.mainStack = []

    def getValidAdiacentBoxes(self, detectedMap):
        availableBoxes = []

        if self.x > 0:
            if detectedMap.surface[self.x - 1][self.y] == DISCOVERED:
                availableBoxes.append([self.x - 1, self.y])

        if self.x < 19:
            if detectedMap.surface[self.x + 1][self.y] == DISCOVERED:
                availableBoxes.append([self.x + 1, self.y])

        if self.y > 0:
            if detectedMap.surface[self.x][self.y - 1] == DISCOVERED:
                availableBoxes.append([self.x, self.y - 1])

        if self.y < 19:
            if detectedMap.surface[self.x][self.y + 1] == DISCOVERED:
                availableBoxes.append([self.x, self.y + 1])

        return availableBoxes

    def updateMap(self, pygameScreen, environment, detectedMap):
        detectedMap.markDetectedWalls(environment, self.x, self.y)
        pygameScreen.blit(detectedMap.image(self.x, self.y), (400, 0))
        pygame.display.flip()
        # Very IMPORTANT! If we don't include the event pump at each frame update, the app will not interact anymore
        # with the OS and it will think that this app is blocked , thus it will try to kill it.
        pygame.event.pump()

    def moveDFSIterative(self, detectedMap):
        initialCoordinates = [self.x, self.y]
        if not initialCoordinates in self.visitedCoords:
            self.visitedCoords.append(initialCoordinates)

            nextCoordinatesToVisit = []
            nextCoordinatesToVisit.extend(self.getValidAdiacentBoxes(detectedMap))

            for possibleCoord in nextCoordinatesToVisit:
                if possibleCoord not in self.visitedCoords:
                    self.mainStack.append(initialCoordinates)  # This is needed for the traceBack
                    self.mainStack.append(possibleCoord)

        if len(self.mainStack) > 0:

            nextCoords = self.mainStack.pop()
            self.x = nextCoords[0]
            self.y = nextCoords[1]
