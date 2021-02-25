from random import randint

from Domain.Environment import Environment
from Domain.Map import DMap
from Domain.Drone import Drone
from Domain.constants import *

import pygame
import time

if __name__ == '__main__':
    # we create the environment
    environment = Environment()
    environment.loadEnvironment("test2.map")
    # print(str(e))

    # we create the map
    map = DMap()

    # initialize the pygame module
    pygame.init()
    # load and set the logo
    logo = pygame.image.load("logo32x32.png")
    pygame.display.set_icon(logo)
    pygame.display.set_caption("drone exploration")

    # we position the drone somewhere in the area
    x = randint(0, 19)
    y = randint(0, 19)

    # cream drona
    drone = Drone(x, y)

    # create a surface on screen that has the size of 800 x 480
    screen = pygame.display.set_mode((800, 400))
    screen.fill(WHITE)
    screen.blit(environment.image(), (0, 0))

    # define a variable to control the main loop
    running = True

    # main loop
    while running:
        map.markDetectedWalls(environment, drone.x, drone.y)
        screen.blit(map.image(drone.x, drone.y), (400, 0))
        pygame.display.flip()

        # event handling, gets all event from the event queue
        for event in pygame.event.get():
            # only do something if the event is of type QUIT
            if event.type == pygame.QUIT:
                # change the value to False, to exit the main loop
                running = False

            # if event.type == pygame.KEYDOWN:
            #     # use this function instead of move
            #     # d.moveDSF(m)
            #     drone.move(map)
        drone.moveDFSRecursive(map, screen, environment)

    pygame.quit()

