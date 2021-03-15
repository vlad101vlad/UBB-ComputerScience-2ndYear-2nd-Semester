class MapRepository:
    def __init__(self, droneMap):
        self._map = droneMap
        self.initializeMap()

    def initializeMap(self):
        self._map.loadMap("test1.map")

    def getMap(self):
        return self._map
