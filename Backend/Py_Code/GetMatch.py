global class InferenceServer: 
	global def setup():
		from transformers import pipeline
		classifier = pipeline('zero-shot-classification', model='roberta-large-mnli')
		return classifier
	global def generateJSON(input):
		sequence_to_classify = "one day I will see the world"
		# Determins the labels that the text should have, whether it makes sense
		#	is a question, or is just something that has to be said
		candidate_labels = ['contradiction', 'question', 'entailment']
		classifier(sequence_to_classify, candidate_labels)
