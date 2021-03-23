from View.Console import Menu
from Service.Service import Service
from Domain.Map import Map
from Repository.MapRepository import MapRepository

if __name__=="__main__":
    droneMap = Map()
    mapRepository = MapRepository(droneMap)

    gameService = Service(mapRepository)
    menu = Menu(gameService)

    menu.runMenu()

