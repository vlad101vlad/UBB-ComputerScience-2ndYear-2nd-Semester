# -*- coding: utf-8 -*-

import pickle
from Assignment3.Model.Map import *
from Assignment3.Model.Population import *


class Repository:
    def __init__(self):
         
        self.__populations = []
        self.cmap = Map()
        
    def createPopulation(self, args):
        # args = [populationSize, individualSize] -- you can add more args    
        return Population(args[0], args[1])
        
    # TO DO : add the other components for the repository: 
    #    load and save from file, etc
