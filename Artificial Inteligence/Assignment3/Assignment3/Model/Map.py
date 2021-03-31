import pickle
from random import *
import numpy as np
import pygame

from Assignment3.Model.constants import *


class Map:
    def __init__(self, n=20, m=20):
        self.n = n
        self.m = m
        self.surface = np.zeros((self.n, self.m))

    def randomMap(self, fill=0.2):
        for i in range(self.n):
            for j in range(self.m):
                if random() <= fill:
                    self.surface[i][j] = 1

    def __str__(self):
        string = ""
        for i in range(self.n):
            for j in range(self.m):
                string = string + str(int(self.surface[i][j]))
            string = string + "\n"
        return string

    def saveMap(self, fileName):
        fileName = fileName + ".map"
        with open(fileName, 'wb') as file:
            pickle.dump(self, file)
            file.close()

    def loadMap(self, fileName):
        fileName = fileName + ".map"
        with open(fileName, "rb") as file:
            dummy = pickle.load(file)
            self.n = dummy.n
            self.m = dummy.m
            self.surface = dummy.surface
