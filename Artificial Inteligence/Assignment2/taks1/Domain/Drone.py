import pygame
from pygame.locals import *
from queue import PriorityQueue
import math


def greedyHeuristic(endNodes, currentNode):
    # We will use the distance between the current node and the end for the heuristic
    return math.sqrt((endNodes[1] - currentNode[1])**2 + (endNodes[0] - currentNode[0])**2)


def addHeuristicToNode(node, endNode):
    return (greedyHeuristic(endNode, node), node)


def getValidAdiacentBoxes(detectedMap, currentNode):
    availableBoxes = []
    x = currentNode[0]
    y = currentNode[1]

    if x > 0:
        if detectedMap.surface[x - 1][y] == 0:
            availableBoxes.append([x - 1, y])

    if x < 19:
        if detectedMap.surface[x + 1][y] == 0:
            availableBoxes.append([x + 1, y])

    if y > 0:
        if detectedMap.surface[x][y - 1] == 0:
            availableBoxes.append([x, y - 1])

    if y < 19:
        if detectedMap.surface[x][y + 1] == 0:
            availableBoxes.append([x, y + 1])

    return availableBoxes


class Drone:
    def __init__(self, x, y):
        self.x = x
        self.y = y
        self._visitedNodes = []
        self._toVisit = PriorityQueue()

    def greedySearch(self, startNode, endNode, detectedMap):
        found = False
        path = [startNode]

        availableBoxes = getValidAdiacentBoxes(detectedMap, startNode)
        for node in availableBoxes:
            self._toVisit.put(addHeuristicToNode(node, endNode))

        while self._toVisit and not found:
            nextPriority = self._toVisit.get()
            nextNode = nextPriority[1]
            self._visitedNodes.append(nextNode[1])
            path.append(nextNode)

            if nextNode == endNode:
                found = True
            else:
                self._toVisit = PriorityQueue()

            availableBoxes = getValidAdiacentBoxes(detectedMap, nextNode)
            for node in availableBoxes:
                self._toVisit.put(addHeuristicToNode(node, endNode))

        return [path, found]

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

    def mapWithDrone(self, mapImage):
        drona = pygame.image.load("drona.png")
        mapImage.blit(drona, (self.y * 20, self.x * 20))

        return mapImage
