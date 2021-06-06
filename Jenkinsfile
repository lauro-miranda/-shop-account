pipeline {
    agent any

    stages {

        stage ('Pull') {
            steps {
                git url: 'https://github.com/lauro-miranda/shop-account.git', branch: 'master'
            }
        }

        stage ('Build') {
            steps {
                script {
                    ls
                    dockerapp = docker.build("lauromiranda/shop-account:${env.BUILD_ID}",
                    '-f ./app/ToSoftware.Shop.Accounts.Api/Dockerfile .')
                }
            }
        }

        stage ('Push') {
            steps {
                script {
                    docker.withRegistry('https://registry.hub.docker.com', 'dockerhub') {
                        dockerapp.push('latest')
                        dockerapp.push("${env.BUILD_ID}")
                    }
                }
            }
        }

    }
}