import pygame
from pygame.locals import *
import sys


class Drone:
    def __init__(self, x, y):
        self.x = x
        self.y = y
        self.visitedCoords = []
        self.stackNextCoordToVisit = []

    def move(self, detectedMap):
        pressed_keys = pygame.key.get_pressed()
        if self.x > 0:
            if pressed_keys[K_UP] and detectedMap.surface[self.x - 1][self.y] == 0:
                self.x = self.x - 1
        if self.x < 19:
            if pressed_keys[K_DOWN] and detectedMap.surface[self.x + 1][self.y] == 0:
                self.x = self.x + 1

        if self.y > 0:
            if pressed_keys[K_LEFT] and detectedMap.surface[self.x][self.y - 1] == 0:
                self.y = self.y - 1
        if self.y < 19:
            if pressed_keys[K_RIGHT] and detectedMap.surface[self.x][self.y + 1] == 0:
                self.y = self.y + 1

    def getValidAdiacentBoxes(self, detectedMap):
        availableBoxes = []

        if self.x > 0:
            if detectedMap.surface[self.x - 1][self.y] == 0:
                availableBoxes.append([self.x - 1, self.y])

        if self.x < 19:
            if detectedMap.surface[self.x + 1][self.y] == 0:
                availableBoxes.append([self.x + 1, self.y])

        if self.y > 0:
            if detectedMap.surface[self.x][self.y - 1] == 0:
                availableBoxes.append([self.x, self.y - 1])

        if self.y < 19:
            if detectedMap.surface[self.x][self.y + 1] == 0:
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

