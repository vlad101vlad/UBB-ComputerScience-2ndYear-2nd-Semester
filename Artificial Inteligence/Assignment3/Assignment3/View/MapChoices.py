from Assignment3.Service.MapService import *


class MapChoices:
    @staticmethod
    def createRandomMap():
        mapName = input("--Enter the map name:~ ")
        MapService.createRandomMap(mapName)


    @staticmethod
    def saveMap():
        pass

    @staticmethod
    def visualiseMap():
        pass
