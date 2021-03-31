from Assignment3.Repository.repository import *


class Controller:
    def __init__(self, repository: Repository):
        # args - list of parameters needed in order to create the controller
        self._repository = repository

    def iteration(self, args):
        # args - list of parameters needed to run one iteration
        # a iteration:
        # selection of the parrents
        # create offsprings by crossover of the parents
        # apply some mutations
        # selection of the survivors
        pass

    def run(self, args):
        # args - list of parameters needed in order to run the algorithm

        # until stop condition
        #    perform an iteration
        #    save the information need it for the satistics

        # return the results and the info for statistics
        pass

    def solver(self, args):
        # args - list of parameters needed in order to run the solver

        # create the population,
        # run the algorithm
        # return the results and the statistics
        pass

    # Map controller
    def loadNewMap(self, mapName):
        self._repository.loadMap(mapName)

    def getCurrentMap(self):
        return self._repository.getCurrentMap()
