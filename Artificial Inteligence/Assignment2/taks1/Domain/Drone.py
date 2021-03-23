import pygame
from pygame.locals import *
from queue import PriorityQueue
from Domain.constants import *
import math
import numpy


def greedyHeuristic(endNodes, currentNode):
    # We will use the distance between the current node and the end for the heuristic
    return math.sqrt((endNodes[1] - currentNode[1]) ** 2 + (endNodes[0] - currentNode[0]) ** 2)


def aStarHeuristic(endNode, currentNode):
    return abs(endNode[1] - currentNode[1]) + abs(endNode[0] - currentNode[0])


def addHeuristicToNode(node, endNode):
    return greedyHeuristic(endNode, node), node

def setMapValuesToInfinity(n, m, someMap):
    for i in range(n):
        for j in range(m):
            someMap[i][j] = INFINITY


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


def reconstructPath(cameFrom, current):
    path = [current]
    current = tuple(current)
    while current in cameFrom.keys():
        current = cameFrom[current]
        path = [current] + path
        current = tuple(current)
    return path


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

        while not self._toVisit.empty() and not found:
            nextPriority = self._toVisit.get()
            nextNode = nextPriority[1]

            self._visitedNodes.append(nextNode)
            path.append(nextNode)

            if nextNode == endNode:
                found = True
            else:
                self._toVisit = PriorityQueue()

            availableBoxes = getValidAdiacentBoxes(detectedMap, nextNode)
            for node in availableBoxes:
                if node not in self._visitedNodes:
                    self._toVisit.put(addHeuristicToNode(node, endNode))

        return [path, found]

    def aStarSearch(self, startNode, endNode, detectedMap):
        cameFrom = {}

        gScoreMap = numpy.zeros((20, 20))
        fScoreMap = numpy.zeros((20, 20))

        setMapValuesToInfinity(20, 20, gScoreMap)
        setMapValuesToInfinity(20, 20, fScoreMap)

        gScoreMap[startNode[0]][startNode[1]] = 0
        fScoreMap[startNode[0]][startNode[1]] = aStarHeuristic(endNode, startNode)

        queueItem = fScoreMap[startNode[0]][startNode[1]], startNode

        self._toVisit.put(queueItem)  # To visit - priority queue with the scores of the fScoreMap for the next node
        self._visitedNodes.append(startNode)  # The open set from which we extract nodes to compute fScores
        while self._visitedNodes:
            currentPriority = self._toVisit.get()
            currentNode = currentPriority[1]

            if currentNode == endNode:
                return reconstructPath(cameFrom, currentNode), True

            availableBoxes = getValidAdiacentBoxes(detectedMap, currentNode)

            self._visitedNodes.remove(currentNode)
            for node in availableBoxes:
                tentative_gScore = gScoreMap[currentNode[0]][currentNode[1]] + 1
                if tentative_gScore < gScoreMap[node[0]][node[1]]:
                    gScoreMap[node[0]][node[1]] = tentative_gScore
                    fScoreMap[node[0]][node[1]] = gScoreMap[node[0]][node[1]] + aStarHeuristic(endNode, node)

                    queueItem = fScoreMap[node[0]][node[1]], node
                    if node not in self._visitedNodes:
                        cameFrom[tuple(node)] = currentNode
                        self._toVisit.put(queueItem)
                        self._visitedNodes.append(node)

        return [], False

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
