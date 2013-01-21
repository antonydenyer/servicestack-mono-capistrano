servicestack-mono-capistrano
============================

An example of a simple service stack application deployed with capistrano-mono-deploy

Clone the repo

And then execute:

    $ bundle

Or install it yourself as:

    $ gem install capistrano-mono-deploy
    
Edit config/deploy.rb to point to your server and use the correct user. 

Then run 

    $ cap deploy
    

References:
* [capistrano-mono-deploy](https://github.com/antonydenyer/capistrano-mono-deploy)
* [railsless-deploy](https://github.com/leehambley/railsless-deploy/)
* [capistrano](https://github.com/capistrano/capistrano/wiki)
* [FastCGI Nginx](http://www.mono-project.com/FastCGI_Nginx)
