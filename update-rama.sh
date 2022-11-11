#!/bin/sh
PATH_REPO="/cicd/CICD-Pruebas"
RAMA_REPO="master"

cd $PATH_REPO

git checkout -b $RAMA_REPO
git fetch
git reset --hard HEAD
git pull origin/$RAMA_REPO

sudo docker-compose up --build -d
