import numpy as np
import pygame

from Domain.constants import *


class DMap:
    def __init__(self):
        self.__n = 20
        self.__m = 20
        self.surface = np.zeros((self.__n, self.__m))
        for i in range(self.__n):
            for j in range(self.__m):
                self.surface[i][j] = UNKNOWN

    def markDetectedWalls(self, e, x, y):
        #   To DO
        # mark on this map the detectedWalls that you detect
        detectedWalls = e.readUDMSensors(x, y)

        # We mark the walls above the drone
        i = x - 1
        if detectedWalls[UP] > 0:
            while i >= 0 and i >= x - detectedWalls[UP]:
                self.surface[i][y] = DISCOVERED
                i = i - 1

        if i >= 0:
            self.surface[i][y] = BRICK

        # We mark the walls below the drone
        i = x + 1
        if detectedWalls[DOWN] > 0:
            while i < self.__n and i <= x + detectedWalls[DOWN]:
                self.surface[i][y] = DISCOVERED
                i = i + 1

        if i < self.__n:
            self.surface[i][y] = BRICK

        # We mark the map to the right of the drone
        j = y + 1
        if detectedWalls[LEFT] > 0:
            while j < self.__m and j <= y + detectedWalls[LEFT]:
                self.surface[x][j] = DISCOVERED
                j = j + 1

        if j < self.__m:
            self.surface[x][j] = BRICK

        # We mark the map to the left of the drone
        j = y - 1
        if detectedWalls[RIGHT] > 0:
            while j >= 0 and j >= y - detectedWalls[RIGHT]:
                self.surface[x][j] = DISCOVERED
                j = j - 1

        if j >= 0:
            self.surface[x][j] = BRICK

        return None

    def image(self, x, y):

        imagine = pygame.Surface((420, 420))

        brick = pygame.Surface((20, 20))
        empty = pygame.Surface((20, 20))

        empty.fill(WHITE)
        brick.fill(BLACK)
        imagine.fill(GRAYBLUE)

        for i in range(self.__n):
            for j in range(self.__m):
                if self.surface[i][j] == BRICK:
                    imagine.blit(brick, (j * 20, i * 20))
                elif self.surface[i][j] == DISCOVERED:
                    imagine.blit(empty, (j * 20, i * 20))

        drona = pygame.image.load("drona.png")
        imagine.blit(drona, (y * 20, x * 20))
        return imagine
