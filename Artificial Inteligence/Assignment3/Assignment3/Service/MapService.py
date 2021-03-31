from Assignment3.Model.Map import *


class MapService:
    def __init__(self):
        pass

    @staticmethod
    def createRandomMap(mapName):
        newMap = Map()
        newMap.randomMap()

        newMap.saveMap(mapName)
