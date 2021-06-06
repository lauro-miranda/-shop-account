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
                    dockerapp = docker.build("lauromiranda/shop-account:${env.BUILD_ID}",
                    '-f Dockerfile .')
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