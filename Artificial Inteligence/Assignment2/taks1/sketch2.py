from View.Console import Menu
from Service.Service import Service
from Domain.Map import Map
from Repository.MapRepository import MapRepository


def searchAStar(mapM, droneD, initialX, initialY, finalX, finalY):
    # TO DO 
    # implement the search function and put it in controller
    # returns a list of moves as a list of pairs [x,y]
    pass


def searchGreedy(mapM, droneD, initialX, initialY, finalX, finalY):
    # TO DO 
    # implement the search function and put it in controller
    # returns a list of moves as a list of pairs [x,y]
    pass


if __name__=="__main__":
    droneMap = Map()
    mapRepository = MapRepository(droneMap)

    gameService = Service(mapRepository)
    menu = Menu(gameService)

    menu.runMenu()

