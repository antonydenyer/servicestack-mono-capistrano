require "capistrano/mono-deploy"

set :application, "service stack deployed with capistrano running on mono"
set :deploy_to, "~/www" 

role :app, "192.168.1.105"                      

