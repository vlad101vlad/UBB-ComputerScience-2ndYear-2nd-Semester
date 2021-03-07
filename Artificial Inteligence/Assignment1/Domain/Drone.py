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

    # def move(self, detectedMap):
    #     pressed_keys = pygame.key.get_pressed()
    #     if self.x > 0:
    #         if pressed_keys[K_UP] and detectedMap.surface[self.x - 1][self.y] == 0:
    #             self.x = self.x - 1
    #     if self.x < 19:
    #         if pressed_keys[K_DOWN] and detectedMap.surface[self.x + 1][self.y] == 0:
    #             self.x = self.x + 1
    #
    #     if self.y > 0:
    #         if pressed_keys[K_LEFT] and detectedMap.surface[self.x][self.y - 1] == 0:
    #             self.y = self.y - 1
    #     if self.y < 19:
    #         if pressed_keys[K_RIGHT] and detectedMap.surface[self.x][self.y + 1] == 0:
    #             self.y = self.y + 1

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

    def moveDSF(self, detectedMap):
        self.stackNextCoordToVisit.extend(self.getValidAdiacentBoxes(detectedMap))

        while self.stackNextCoordToVisit:
            nextCoordToVisit = self.stackNextCoordToVisit.pop()
            if nextCoordToVisit not in self.visitedCoords:
                self.visitedCoords.append(nextCoordToVisit)
                self.x = nextCoordToVisit[0]
                self.y = nextCoordToVisit[1]
                break

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

    def moveDFSRecursive(self, detectedMap, pygameScreen, environment):
        # VERY IMPORTANT! We must update the detectedMap with the sensor information before we get the next possible
        # coordinates to visit
        self.updateMap(pygameScreen, environment, detectedMap)
        time.sleep(SLOW)

        nextCoordinatesToVisit = []
        nextCoordinatesToVisit.extend(self.getValidAdiacentBoxes(detectedMap))
        # We get the initial coordinates for the trace coming back from the recursion
        initialCoordinates = [self.x, self.y]

        for nextCoord in nextCoordinatesToVisit:
            if nextCoord not in self.visitedCoords:
                self.visitedCoords.append(nextCoord)
                self.x = nextCoord[0]
                self.y = nextCoord[1]

                self.moveDFSRecursive(detectedMap, pygameScreen, environment)

                # When we come back from the recursive call, we restore the initial coordinates of the drone and
                # update teh map, in order to be able to see the trace
                self.x = initialCoordinates[0]
                self.y = initialCoordinates[1]
                self.updateMap(pygameScreen, environment, detectedMap)
                time.sleep(FAST)
